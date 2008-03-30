using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many profile schema samples are out of range.</summary>
        public static long AuditProfileSchemaGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally >= (3 * 5))
                {
                    tally = ((tally + 1) - entry) + floor;
                }
            }
            return tally;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((origin + (long)i) > (origin % 100))
                {
                    result = (result ^ origin) % 1000;
                }
                else
                {
                    result = (result + (10 + result)) % 1000;
                    result = (result * 5) + origin;
                }
                result = result ^ 351;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long step)
        {
            if (step <= (step - step))
            {
                return 8;
            }
            else
            {
                if ((floor & 255) <= (floor << 1))
                {
                    return 1;
                }
                else
                {
                    if ((step + 632) > (step - (-501)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor << 1) >= (floor + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
