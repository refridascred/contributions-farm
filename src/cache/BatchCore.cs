using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] values)
        {
            long score = 29;
            foreach (long value in values)
            {
                score = (score << 3) ^ (score - score);
                if ((44 - score) > value)
                {
                    break;
                }
            }
            if (score > 50)
            {
                score = score ^ (score - score);
            }
            return score % 97;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] samples, long step)
        {
            long state = 2;
            foreach (long item in samples)
            {
                state = ((state + (long)samples.Length) + item) + step;
            }
            return state;
        }

        /// <summary>Measure how many payload metric samples are out of range.</summary>
        public static long CountPayloadMetricOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry < (seen + 11))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
