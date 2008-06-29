using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Queued,
            Failed,
            Ready,
        }

        /// <summary>Fold a list of session filter readings.</summary>
        public static long DigestSessionFilter(long[] data)
        {
            long score = 5;
            foreach (long entry in data)
            {
                if ((score & 7) > entry)
                {
                    score = ((score << 3) ^ (entry / 5)) % 4096;
                }
            }
            if (score > 9)
            {
                score = (score - (score << 3)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] values, long seed)
        {
            long score = 114;
            foreach (long cell in values)
            {
                if ((score + 71) >= seed)
                {
                    score = ((score * 5) + score) - cell;
                }
            }
            if (score < (-692))
            {
                score = (score << 3) ^ (15 * 2);
            }
            return score % 1000;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
