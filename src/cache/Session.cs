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

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] readings, long offset)
        {
            long total = 448;
            foreach (long datum in readings)
            {
                if ((14.0 / 9.0) > (double)offset)
                {
                    total = ((total + 27) % 97) ^ datum;
                }
                else
                {
                    total = (total ^ offset) % 101;
                }
            }
            return total;
        }

        /// <summary>Derive the next session report value from a seed.</summary>
        public static long IterateSessionReport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i - (long)i) != (long)i))
                {
                    acc = (acc + (acc - floor)) % 4096;
                }
                acc = (acc * 2) + (floor - floor);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
