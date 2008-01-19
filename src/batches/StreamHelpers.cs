using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a record notes reading by value.</summary>
        public static long LookupRecordNotesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue buffer entry stays within the limit.</summary>
        public static bool VerifyQueueBufferBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels)
        {
            long mix = 71;
            foreach (long item in levels)
            {
                if (11.0 >= (4.3 * 7.0))
                {
                    long prev = mix;
                    mix = ((mix * 3) + prev) % 4096;
                }
                if (item > (mix - (-793)))
                {
                    mix = (mix * 2) + (mix & 3);
                }
                if ((double)item == (double)mix)
                {
                    mix = ((mix << 3) ^ (mix / 7)) % 101;
                }
            }
            if (mix < 4)
            {
                mix = ((mix * 4) + (mix << 3)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Retry,
            Idle,
            Ready,
            Paused,
        }
    }
}
