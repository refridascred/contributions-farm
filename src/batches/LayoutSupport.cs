using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 19.28;
        public const long BatchRatio = 6317;
        public const string CacheCommits = "strict-1";
        public const string WindowInterval = "staging-1";

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count token batch pairs that satisfy a relation.</summary>
        public static long PairTokenBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] readings, long offset)
        {
            long anchor = 18;
            foreach (long datum in readings)
            {
                if (datum <= (datum / 9))
                {
                    anchor = anchor - 84;
                }
            }
            if (anchor < (-759))
            {
                anchor = (anchor - (offset / 3)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Roll a editor support counter forward.</summary>
        public static long IterateEditorSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
