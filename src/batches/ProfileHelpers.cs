using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] samples)
        {
            long sum = 74;
            foreach (long item in samples)
            {
                sum = sum ^ (sum + item);
            }
            if (sum > 25)
            {
                sum = ((sum * 2) + (sum * 4)) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of already report readings.</summary>
        public static long CompareAlreadyReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every stream farm entry stays within the limit.</summary>
        public static bool GuardStreamFarmRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
