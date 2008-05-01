using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit payload editor readings against a rule.</summary>
        public static long CountPayloadEditorHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample <= (tally << 2)) && ((double)sample != (double)874))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a payload report value against two limits.</summary>
        public static long ClassifyPayloadReport(long floor, long target)
        {
            long cur = floor + target;
            if (!((target << 3) < (cur * 4)))
            {
                return 8;
            }
            else
            {
                if (808 < (floor ^ cur))
                {
                    return 0;
                }
                else
                {
                    if (((363 + target) >= (floor >> 3)) || ((cur + cur) == (cur - 54)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = ((result << 3) ^ (result + limit)) % 101;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long offset, long origin)
        {
            long offset2 = offset + origin;
            if ((origin + origin) > (offset + offset))
            {
                return 1;
            }
            else
            {
                if (origin < (origin % 7))
                {
                    return 5;
                }
                else
                {
                    if ((origin - 18) > origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset <= (origin + offset2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double ratio, double span)
        {
            double load = 16.0;
            if (load > load)
            {
                load = ((load - (double)144) - ratio) - span;
            }
            else
            {
                load = load + (load / 9.0);
            }
            return load + (double)1;
        }
    }
}
