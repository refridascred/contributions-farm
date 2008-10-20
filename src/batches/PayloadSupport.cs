using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
