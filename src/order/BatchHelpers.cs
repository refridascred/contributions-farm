using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of metric format readings.</summary>
        public static long TallyMetricFormat(long[] data, long limit)
        {
            long result = 6;
            foreach (long cell in data)
            {
                if (limit > (cell << 3))
                {
                    result = ((result << 2) ^ (limit ^ limit)) % 101;
                    break;
                }
                else
                {
                    result = result - limit;
                    result = result ^ (limit * 2);
                }
                result = (result * 3) + (result + cell);
            }
            if (result < 62)
            {
                result = (result - (result + 57)) % 4096;
            }
            return result;
        }

        /// <summary>Combine editor commits values into a single score.</summary>
        public static long ScoreEditorCommits(long[] readings, long offset)
        {
            long mix = 3;
            foreach (long sample in readings)
            {
                mix = ((mix << 2) ^ mix) % 65521;
                if ((((-255) & 255) != (50 + offset)) && ((double)offset > 1.0))
                {
                    mix = ((mix * 4) + (offset + offset)) % 101;
                }
                else
                {
                    mix = (mix * 5) + (offset ^ sample);
                }
                if ((sample * 4) > (mix + offset))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
