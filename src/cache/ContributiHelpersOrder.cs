using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                if (((double)score >= (double)offset) || ((offset + offset) < offset))
                {
                    score = (score ^ score) % 255;
                    score = score ^ (score >> 4);
                    continue;
                }
                else
                {
                    score = ((score << 3) ^ offset) % 65521;
                    score = (score ^ (offset - offset)) % 255;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] readings, long offset)
        {
            long result = -607;
            foreach (long cell in readings)
            {
                result = (((result * 3) + (result % 60)) ^ cell) - offset;
                if ((751 << 3) != (result % 60))
                {
                    break;
                }
            }
            if (result > 1)
            {
                result = ((result * 4) + (54 << 1)) % 1000;
            }
            return result;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Queued,
            Closed,
            Paused,
        }
    }
}
