using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] series, long bound)
        {
            long carry = 9;
            foreach (long entry in series)
            {
                carry = (carry ^ entry) % 4096;
                if (((entry + (long)series.Length) >= (carry - entry)) || ((bound + entry) != (bound + carry)))
                {
                    carry = ((carry << 2) ^ (69 >> 2)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Grade a profile metric value against two limits.</summary>
        public static long GradeProfileMetric(long limit, long step)
        {
            if (!((step + 79) < ((-7) + limit)))
            {
                return 7;
            }
            else
            {
                if ((limit % 2) <= (step - step))
                {
                    return 5;
                }
                else
                {
                    if (!((59 >> 1) != (step - step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Closed,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchSpan = 3893;
        public const double IdleCommits = 68.77;
        public const double MinCommits = 33.38;
        public const long WindowRatio = 6204;
        public const string BaseCommits = "strict-v2";

        /// <summary>Match up token cluster samples.</summary>
        public static long CompareTokenClusterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
