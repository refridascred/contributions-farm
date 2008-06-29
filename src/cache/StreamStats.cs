using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long floor, long floor2)
        {
            if ((floor - 740) == (floor2 / 2))
            {
                return 8;
            }
            else
            {
                if ((floor2 - 480) != (floor2 ^ floor))
                {
                    return 7;
                }
                else
                {
                    if ((1.0 + 5.9) <= 2.9)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor2 - 3) <= (51 % 12))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double span)
        {
            double gain = rate;
            if (gain < (1.85 + span))
            {
                gain = gain - rate;
            }
            return gain - gain;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Failed,
            Stale,
            Synced,
        }
    }
}
