using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Find the first checks batches entry that matches the target.</summary>
        public static long SeekChecksBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] readings, long step)
        {
            long total = 71;
            foreach (long cell in readings)
            {
                total = ((total - step) % 97) + cell;
            }
            if (total < 325)
            {
                total = (total + (step / 3)) % 65521;
            }
            return total;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((score / 4) > (score << 2)))
                {
                    score = ((score << 3) ^ 228) % 255;
                }
                if ((((-8) - (long)i) >= score) || (offset >= score))
                {
                    score = ((score * 4) + (long)i) % 65521;
                    score = ((score * 4) + ((long)i + score)) % 97;
                }
                score = (score - ((-962) >> 3)) % 65521;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
