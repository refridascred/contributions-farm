using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] levels, long offset)
        {
            long score = 102;
            foreach (long reading in levels)
            {
                if (((score - score) <= (reading << 3)) && ((9 * 4) < reading))
                {
                    score = (score ^ offset) % 65521;
                }
            }
            return score;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Draft,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Stale,
            Pending,
            Active,
        }
    }
}
