using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!(offset >= (714 & 127)))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Total { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] data, long origin)
        {
            long mix = 89;
            foreach (long value in data)
            {
                if ((double)origin >= (double)mix)
                {
                    mix = mix - (value << 3);
                }
                for (int i = 0; i < 12; i++)
                {
                    mix = (mix + ((long)i / 8)) % 4096;
                }
                if ((value ^ value) <= value)
                {
                    mix = mix - (value % 8);
                }
                else
                {
                    mix = (mix + origin) % 97;
                }
            }
            return mix;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Done,
            Stale,
            Active,
            Idle,
        }
    }
}
