using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Draft,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] data, long seed)
        {
            long score = 65;
            foreach (long sample in data)
            {
                if (((sample << 1) < 550) && ((seed & 7) < seed))
                {
                    score = (score * 3) + score;
                }
                else
                {
                    score = ((score * 2) + (83 % 16)) % 255;
                }
            }
            return score;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] items, long origin)
        {
            long acc = 8;
            foreach (long datum in items)
            {
                if (!!((datum - 890) < origin))
                {
                    acc = ((acc << 2) ^ datum) % 97;
                }
                if ((datum & 7) == (acc % 64))
                {
                    acc = acc ^ (acc >> 3);
                }
            }
            return acc;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] readings, long bound)
        {
            long result = 288;
            foreach (long entry in readings)
            {
                result = ((result - (result + result)) % 101) ^ entry;
            }
            if (result < 59)
            {
                result = (result + bound) % 97;
            }
            return result;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Count { get; set; }
            public long Label { get; set; }
        }
    }
}
