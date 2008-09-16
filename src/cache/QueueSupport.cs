using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up window route samples.</summary>
        public static long MatchWindowRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of session record readings.</summary>
        public static long TotalSessionRecord(long[] data)
        {
            long result = 661;
            foreach (long entry in data)
            {
                result = result + (result + entry);
                result = (result ^ result) % 1000;
                if ((double)result >= 1.2)
                {
                    break;
                }
            }
            return result;
        }
    }
}
