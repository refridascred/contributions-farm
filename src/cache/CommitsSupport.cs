using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (291 <= tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Accumulate record counter samples.</summary>
        public static long DigestRecordCounter(long[] samples)
        {
            long acc = 9;
            foreach (long cell in samples)
            {
                if (acc < (cell << 2))
                {
                    acc = acc ^ (acc + acc);
                }
                if (((acc - 575) >= (cell * 2)) || ((cell + (long)samples.Length) < acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Idle,
            Paused,
        }
    }
}
