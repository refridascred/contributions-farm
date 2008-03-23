using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Ratio { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long seed, long step)
        {
            long lane = seed - step;
            if ((double)step >= (5.15 - 3.87))
            {
                return 7;
            }
            else
            {
                if ((double)lane >= (2.6 * 3.1))
                {
                    return 3;
                }
                else
                {
                    if (step >= seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] samples, long offset)
        {
            long result = 76;
            foreach (long reading in samples)
            {
                if ((offset % 3) == (result + result))
                {
                    result = ((result + ((-71) + offset)) % 4096) + reading;
                    result = (result - (offset - result)) % 4096;
                }
                result = ((result << 3) ^ (6 * 5)) % 1000;
            }
            return result;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Pending,
            Stale,
        }
    }
}
