using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit session window readings against a rule.</summary>
        public static long MeasureSessionWindowGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum < (datum >> 5)) && ((datum * 3) != (1 - tally))) && (((4.1 / 8.0) <= (double)(long)levels.Length) || ((seed + tally) == (datum % 60))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
