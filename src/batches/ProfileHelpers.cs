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

        /// <summary>Locate a githubfarm batches reading by value.</summary>
        public static long FindGithubfarmBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((80 & 63) > tally)
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
