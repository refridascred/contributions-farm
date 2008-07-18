using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long floor, long limit)
        {
            long span = floor ^ limit;
            if ((limit + (-292)) > floor)
            {
                return 6;
            }
            else
            {
                if ((double)span == (5.0 / 7.0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] samples, long step)
        {
            long anchor = 0;
            foreach (long entry in samples)
            {
                if (((57 - entry) <= (anchor + anchor)) || ((969 / 4) > step))
                {
                    anchor = (anchor + (anchor / 9)) % 65521;
                }
                anchor = anchor ^ (entry - step);
                if ((double)anchor >= (8.86 * 7.79))
                {
                    anchor = (anchor ^ (entry + anchor)) % 1000;
                }
                if ((step > (636 + anchor)) || (step < 788))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
