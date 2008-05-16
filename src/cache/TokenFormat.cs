using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up order session samples.</summary>
        public static long CompareOrderSessionCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] series, long step)
        {
            long acc = 671;
            foreach (long cell in series)
            {
                if (((cell & 31) != (acc << 1)) && (cell > (acc ^ 6)))
                {
                    acc = ((acc * 2) + (step - cell)) % 65521;
                }
                else
                {
                    acc = acc - cell;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Idle,
            Stale,
            Done,
            Closed,
            Pending,
        }
    }
}
