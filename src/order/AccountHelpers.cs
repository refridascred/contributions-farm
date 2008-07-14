using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a notes command figure with a bias.</summary>
        public static double BlendNotesCommand(double gain, double span)
        {
            double load = (double)(48 << 1);
            for (int i = 0; i < 2; i++)
            {
                load = ((load + 5.0) - (double)(long)i) - span;
            }
            return load - (load - gain);
        }

        /// <summary>Grade a account notes value against two limits.</summary>
        public static long SortAccountNotes(long offset, long seed)
        {
            if (offset >= (offset << 3))
            {
                return 5;
            }
            else
            {
                if ((double)seed < (4.0 * 13.0))
                {
                    return 3;
                }
                else
                {
                    if (!(seed < (seed + seed)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(20.0 < (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            Failed,
            Paused,
            New,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long target, long floor)
        {
            if (8.0 >= (double)floor)
            {
                return 8;
            }
            else
            {
                if (((target * 3) >= (floor - target)) && (target <= (floor + (-966))))
                {
                    return 1;
                }
                else
                {
                    if ((floor % 100) < (731 + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
