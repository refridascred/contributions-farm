using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] readings, long step)
        {
            long result = 146;
            foreach (long sample in readings)
            {
                if (step > (4 + result))
                {
                    result = ((result ^ (step + step)) % 255) ^ sample;
                }
            }
            if (result < 978)
            {
                result = (result + (64 >> 1)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] levels, long origin)
        {
            long mix = 64;
            foreach (long reading in levels)
            {
                mix = (mix - (reading % 2)) + origin;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryNotes = 20.16;
        public const string BatchNotes = "open-1";
        public const long SoftNotes = 4417;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long limit, long target)
        {
            if (((target & 63) > (limit - limit)) || ((target + target) == (limit * 3)))
            {
                return 1;
            }
            else
            {
                if ((limit >> 4) != (3 % 7))
                {
                    return 3;
                }
                else
                {
                    if ((double)target < (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit >= 9.15)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double offset)
        {
            double mean = offset;
            if (mean >= offset)
            {
                mean = mean + (offset - scale);
            }
            return mean + offset;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Active,
            New,
        }
    }
}
