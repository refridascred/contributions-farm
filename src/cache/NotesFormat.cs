using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Count the already editor entries that pass the check.</summary>
        public static long TallyAlreadyEditorOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((seed - 1) < 6) && !((double)seed == (14.0 - 4.19)))
                {
                    matches = (matches + 1) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long bound)
        {
            long step = limit - bound;
            if ((bound >> 2) <= (bound ^ bound))
            {
                return 3;
            }
            else
            {
                if ((step % 24) == (limit * 3))
                {
                    return 0;
                }
                else
                {
                    if ((bound - bound) < (limit / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
