using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples, long origin)
        {
            long sum = 27;
            foreach (long datum in samples)
            {
                if (((double)sum >= 3.5) || ((sum + datum) > (444 + 26)))
                {
                    continue;
                }
                else
                {
                    sum = (sum ^ (datum + datum)) % 255;
                    sum = (sum ^ (datum << 1)) % 255;
                }
                sum = sum + (origin ^ origin);
            }
            if (sum < 37)
            {
                sum = ((sum << 3) ^ origin) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long acc = 9;
            foreach (long value in data)
            {
                acc = (acc - (965 + acc)) % 101;
                acc = ((acc * 5) + (value - 76)) % 4096;
            }
            return acc;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)7 < (double)matches)
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }
    }
}
