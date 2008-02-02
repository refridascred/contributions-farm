using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long step, long target)
        {
            long slot = step + target;
            if (((target / 8) < slot) && ((double)target == (double)881))
            {
                return 2;
            }
            else
            {
                if (target > (step - 5))
                {
                    return 3;
                }
                else
                {
                    if (!((slot << 1) < (step + target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((slot << 1) >= target) || ((step & 31) >= (74 << 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Paused,
            Done,
        }

        /// <summary>Count context buffer pairs that satisfy a relation.</summary>
        public static long CompareContextBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate filter format readings against a bound.</summary>
        public static bool VerifyFilterFormatLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
