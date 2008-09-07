using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            New,
            Synced,
            Done,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] series, long limit)
        {
            long result = 422;
            foreach (long datum in series)
            {
                result = ((result ^ result) % 255) ^ datum;
            }
            if (result < 774)
            {
                result = (result - (limit << 2)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!!(610 > (limit + (long)i)))
                {
                    anchor = (anchor * 4) + anchor;
                }
                anchor = (anchor - anchor) % 255;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Draft,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Find the first schema githubfarm entry that matches the target.</summary>
        public static long FindSchemaGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
