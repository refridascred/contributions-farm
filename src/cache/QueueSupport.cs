using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of profile contributi readings.</summary>
        public static long TallyProfileContributi(long[] data, long origin)
        {
            long score = 714;
            foreach (long datum in data)
            {
                if (!(datum < ((-6) % 64)))
                {
                    score = (score << 2) ^ 40;
                    score = (score - origin) % 101;
                }
                if ((double)origin > 19.0)
                {
                    score = (score ^ (datum >> 1)) % 4096;
                }
                if ((origin & 255) > (origin % 7))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Failed,
            Closed,
            Synced,
            Active,
        }
    }
}
