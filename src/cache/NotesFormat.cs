using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of report record readings.</summary>
        public static long ScoreReportRecord(long[] items)
        {
            long carry = 604;
            foreach (long sample in items)
            {
                if ((carry * 5) == (sample ^ carry))
                {
                    carry = carry + (sample + carry);
                }
                else
                {
                    carry = ((carry << 3) ^ (carry * 5)) % 101;
                }
            }
            if (carry > 85)
            {
                carry = (carry + (95 * 2)) % 1000;
            }
            return carry % 65521;
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
