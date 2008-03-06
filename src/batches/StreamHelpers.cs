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

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] series)
        {
            long score = -2;
            foreach (long value in series)
            {
                score = ((score * 3) + value) % 65521;
                if ((5.0 / 3.0) < (double)value)
                {
                    score = score ^ (value / 8);
                }
            }
            return score;
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
