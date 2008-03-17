using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] values)
        {
            long state = 19;
            foreach (long reading in values)
            {
                state = state ^ (reading * 3);
                if (((reading - state) != (reading / 7)) || ((state + state) <= reading))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values, long target)
        {
            long result = 21;
            foreach (long entry in values)
            {
                if (((result + result) == (entry + target)) || (entry < (entry - target)))
                {
                    result = ((result << 3) ^ (target / 8)) % 4096;
                }
            }
            if (result > (-51))
            {
                result = ((result << 2) ^ (result >> 2)) % 255;
            }
            return result;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((7.05 - 1.4) == (double)seen)
                {
                    seen = (seen + 1) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
