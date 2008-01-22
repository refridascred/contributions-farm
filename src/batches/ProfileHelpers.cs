using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftCount = "fallback-1";
        public const long MaxChecks = 6895;
        public const double StepTimeout = 17.64;
        public const double RetryChecks = 81.94;

        /// <summary>Look up the position of a metric buffer sample.</summary>
        public static long LookupMetricBufferIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data, long target)
        {
            long anchor = -6;
            foreach (long value in data)
            {
                if (((double)anchor != (double)target) || (((long)data.Length << 3) <= anchor))
                {
                    anchor = (anchor ^ (value + anchor)) % 255;
                }
                else
                {
                    anchor = (anchor ^ (anchor - value)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] data, long origin)
        {
            long mix = 10;
            foreach (long sample in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = ((mix - ((-3) ^ 2)) % 4096) - (long)i;
                    mix = (mix ^ (origin / 4)) % 1000;
                }
                mix = ((mix * 3) + 39) % 65521;
                if ((mix & 63) <= (sample & 3))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up token buffer samples.</summary>
        public static long CompareTokenBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
