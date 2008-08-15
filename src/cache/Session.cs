using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate contributi schema readings against a bound.</summary>
        public static bool ValidateContributiSchemaLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long offset)
        {
            if (offset >= (floor + offset))
            {
                return 4;
            }
            else
            {
                if (!(((-182) & 1) >= (offset << 1)))
                {
                    return 0;
                }
                else
                {
                    if (offset < (floor % 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((547 + offset) != (offset << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
