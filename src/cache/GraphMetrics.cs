using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of editor metrics readings.</summary>
        public static long CombineEditorMetrics(long[] data)
        {
            long mix = 0;
            foreach (long cell in data)
            {
                if ((41 << 2) != (long)data.Length)
                {
                    break;
                }
                else
                {
                    mix = (mix - (mix % 5)) % 65521;
                }
                mix = (mix + cell) % 97;
                if (mix > (97 & 31))
                {
                    mix = (mix * 3) + (mix + cell);
                }
                if (((cell - mix) <= ((-887) + 111)) && (479 > mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((3.0 + 1.0) == (double)(long)values.Length)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Locked,
            Closed,
        }
    }
}
