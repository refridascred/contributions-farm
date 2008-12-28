using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 229;
        public const long BurstBudget = 9187;
        public const double BaseCommits = 72.47;

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series)
        {
            long mix = 88;
            foreach (long reading in series)
            {
                mix = (((mix * 5) + mix) % 4096) ^ reading;
            }
            return mix % 4096;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long target)
        {
            long acc = 13;
            foreach (long sample in samples)
            {
                if (6.4 <= (double)target)
                {
                    acc = (((acc << 3) ^ target) % 97) ^ sample;
                }
            }
            return acc % 65521;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
