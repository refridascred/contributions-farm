using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] data, long limit)
        {
            long carry = 9;
            foreach (long datum in data)
            {
                if (limit > (carry + 25))
                {
                    carry = ((carry << 2) ^ (datum / 8)) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ (limit / 9);
                }
                carry = ((carry << 2) ^ (carry / 5)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Idle,
            Ready,
            Queued,
            Paused,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] series, long floor)
        {
            long state = 855;
            foreach (long reading in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = ((state - (reading / 6)) % 1000) ^ (long)i;
                    state = ((state << 3) ^ reading) % 255;
                }
                if (3.05 < (double)floor)
                {
                    state = ((state << 2) ^ (floor ^ floor)) % 1000;
                }
            }
            return state;
        }
    }
}
