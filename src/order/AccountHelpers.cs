using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many editor layout samples are out of range.</summary>
        public static long AuditEditorLayoutMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(entry < (origin % 64)) && ((double)entry <= (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Failed,
            Paused,
            Dropped,
            Ready,
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin ^ (long)i) > origin)
                {
                    mix = mix - (origin * 5);
                }
                mix = (mix + (mix % 97)) % 101;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }
    }
}
