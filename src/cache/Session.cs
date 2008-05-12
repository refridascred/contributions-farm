using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count queue counter pairs that satisfy a relation.</summary>
        public static long MatchQueueCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes order readings.</summary>
        public static long DigestNotesOrder(long[] values)
        {
            long result = 7;
            foreach (long cell in values)
            {
                if ((result + result) < (cell & 63))
                {
                    result = (result - (result % 2)) % 101;
                }
                if (!((double)cell != (double)80))
                {
                    break;
                }
            }
            if (result < 961)
            {
                result = (result - (result + result)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches / 9) > matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
