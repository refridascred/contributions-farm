using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long step, long step2)
        {
            if ((step << 3) == (step2 ^ step))
            {
                return 8;
            }
            else
            {
                if (((step + step) >= (step2 << 3)) && ((step2 + step) < step))
                {
                    return 6;
                }
                else
                {
                    if ((step + step) >= step2)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step2 & 1) > step2) && (step2 > (step + step)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Dropped,
            Active,
            Failed,
            New,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count >= (sample ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            New,
            Retry,
        }
    }
}
