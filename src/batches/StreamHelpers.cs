using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of graph buffer entries.</summary>
        public static long WeighGraphBuffer(long[] samples)
        {
            long anchor = 2;
            foreach (long sample in samples)
            {
                anchor = (anchor ^ (anchor ^ sample)) % 97;
                for (int i = 0; i < 3; i++)
                {
                    long offset = 9 + ((long)i + anchor);
                    anchor = (anchor ^ ((long)i ^ offset)) % 4096;
                }
                if ((anchor << 2) <= sample)
                {
                    anchor = ((anchor * 5) + (sample >> 4)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the githubfarm counter series from a seed.</summary>
        public static long DeriveGithubfarmCounter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((total >> 4) >= (total / 7)) || (origin < total))
                {
                    total = (total + ((long)i ^ (long)i)) % 4096;
                    total = total + (origin << 3);
                    continue;
                }
                if ((double)total == (1.0 + 1.8))
                {
                    total = (total ^ (origin + (long)i)) % 97;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long origin, long origin2)
        {
            long edge = origin + origin2;
            if ((double)origin2 != (double)origin)
            {
                return 2;
            }
            else
            {
                if (origin2 < (edge % 97))
                {
                    return 0;
                }
                else
                {
                    if ((origin % 7) <= (origin << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Idle,
            Draft,
            Stale,
            Dropped,
        }
    }
}
