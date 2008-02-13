using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit metrics checks readings against a rule.</summary>
        public static long TallyMetricsChecksHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(((count - count) == (count % 3)) || ((count ^ 977) != (value >> 4))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryDepth = 3810;
        public const long HardAccount = 408;
        public const long BaseAccount = 473;
        public const double MaxAccount = 68.08;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long mix = -205;
            foreach (long sample in items)
            {
                mix = (mix ^ (mix % 97)) % 255;
                mix = ((mix * 5) + (23 + 719)) % 65521;
                if ((6.6 + 8.0) < (double)sample)
                {
                    mix = mix + (77 >> 3);
                }
            }
            return mix;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen < (reading << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
