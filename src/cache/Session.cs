using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Idle,
            New,
        }

        /// <summary>Combine counter entry values into a single score.</summary>
        public static long ScoreCounterEntry(long[] data)
        {
            long result = -43;
            foreach (long cell in data)
            {
                if ((cell / 9) != (result << 1))
                {
                    result = ((result << 2) ^ result) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
