using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of payload notes readings.</summary>
        public static long CombinePayloadNotes(long[] values, long floor)
        {
            long mix = 8;
            foreach (long datum in values)
            {
                if ((double)floor > 6.0)
                {
                    mix = ((mix * 4) + (floor * 2)) + datum;
                }
            }
            return mix;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (9.52 >= (double)hits)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 9402;
        public const string StepCount = "fallback-1";
        public const long RetryCommand = 8592;
        public const long SoftInterval = 7645;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            New,
            Queued,
        }
    }
}
