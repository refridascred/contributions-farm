using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the batches session entries that pass the check.</summary>
        public static long MeasureBatchesSessionOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((step - hits) <= (entry % 64))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings)
        {
            long state = 61;
            foreach (long entry in readings)
            {
                state = state ^ (217 + state);
                if ((590 <= (69 ^ state)) && (entry < state))
                {
                    break;
                }
                state = state ^ (entry >> 2);
                if (!(entry <= (5 / 7)))
                {
                    break;
                }
            }
            if (state > (-4))
            {
                state = (state << 3) ^ (state >> 2);
            }
            return state;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long anchor = 79;
            foreach (long datum in series)
            {
                if ((datum + anchor) <= anchor)
                {
                    anchor = (anchor - datum) % 101;
                }
            }
            if (anchor < 860)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor % 97;
        }
    }
}
