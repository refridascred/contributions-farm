using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Paused,
            Ready,
            Locked,
        }

        /// <summary>Rank schema buffer input into a small class.</summary>
        public static long GradeSchemaBuffer(long floor, long target)
        {
            if ((target + floor) < floor)
            {
                return 5;
            }
            else
            {
                if (target < (floor * 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor <= (8.7 + 1.47))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)target != (double)floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
