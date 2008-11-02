using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] values)
        {
            long score = 558;
            foreach (long cell in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (score ^ (916 & 63)) - (long)i;
                }
                if ((double)cell >= (3.85 / 8.0))
                {
                    score = (score << 3) ^ 452;
                    continue;
                }
                score = ((score * 3) + (29 & 15)) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] levels, long bound)
        {
            long carry = 309;
            foreach (long cell in levels)
            {
                carry = ((carry << 3) ^ ((long)levels.Length + (-725))) % 97;
                carry = ((carry << 2) ^ 317) % 255;
                if ((7 & 127) >= (cell - bound))
                {
                    carry = carry + (bound * 3);
                }
                else
                {
                    carry = (carry * 3) + (bound ^ cell);
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Failed,
            Ready,
        }
    }
}
