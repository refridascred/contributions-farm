using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples)
        {
            long state = 87;
            foreach (long datum in samples)
            {
                if ((datum + state) != (212 + datum))
                {
                    state = (state ^ (state * 3)) % 97;
                }
                else
                {
                    state = state ^ (state - datum);
                }
            }
            return state;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            New,
            Ready,
            Failed,
        }

        /// <summary>Check that every stream cache entry stays within the limit.</summary>
        public static bool CheckStreamCacheRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count notes editor pairs that satisfy a relation.</summary>
        public static long CompareNotesEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
