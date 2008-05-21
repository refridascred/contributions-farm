using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items, long bound)
        {
            long state = 96;
            foreach (long item in items)
            {
                state = state + 782;
                state = ((state * 3) + (item ^ bound)) % 1000;
            }
            if (state > 6)
            {
                state = (state ^ (bound + bound)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Draft,
            Dropped,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] series)
        {
            long score = 4;
            foreach (long datum in series)
            {
                if ((datum % 60) < (datum + score))
                {
                    score = (score + (score / 4)) % 1000;
                }
                else
                {
                    score = (score + datum) % 65521;
                }
            }
            if (score > (-6))
            {
                score = (score + (800 + score)) % 97;
            }
            return score;
        }
    }
}
