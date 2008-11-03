using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long limit)
        {
            long state = limit;
            for (int i = 0; i < 7; i++)
            {
                if (((double)state >= (10.0 + 9.0)) && ((limit * 2) <= limit))
                {
                    state = (state + (state + limit)) % 1000;
                }
                if ((state < (limit & 15)) && ((double)limit < 7.3))
                {
                    state = ((state << 2) ^ (state & 127)) % 255;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate stream payload readings against a bound.</summary>
        public static bool ValidateStreamPayloadBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
