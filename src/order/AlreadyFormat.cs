using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a payload tools reading.</summary>
        public static double ScalePayloadTools(double bias, double span)
        {
            double gain = (bias - bias) / 8.0;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (1.15 * 3.0)) - (double)(long)i;
            }
            return gain + (span - span);
        }

        /// <summary>Audit notes checks readings against a rule.</summary>
        public static long CountNotesChecksGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((15.0 + 2.4) >= (double)limit)
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long floor)
        {
            if (!((984 >> 3) < (limit * 2)))
            {
                return 2;
            }
            else
            {
                if ((limit + limit) >= ((-342) << 2))
                {
                    return 3;
                }
                else
                {
                    if ((floor + limit) > (limit ^ floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor - floor) == (limit * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Synced,
            Queued,
            New,
            Draft,
        }
    }
}
