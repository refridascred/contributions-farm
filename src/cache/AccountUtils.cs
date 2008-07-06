using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "standard-1";
        public const long MaxFactor = 5127;
        public const double MinFilter = 18.15;
        public const long StepLevel = 3712;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Pending,
            Locked,
            Done,
        }

        /// <summary>Rank context graph input into a small class.</summary>
        public static long ClassifyContextGraph(long bound, long offset)
        {
            long edge = bound - offset;
            if (!((double)offset >= (11.0 * 9.38)))
            {
                return 7;
            }
            else
            {
                if ((double)bound < (5.5 * 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((edge + bound) <= edge)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((edge + bound) <= bound) && (edge > (offset & 63)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
