using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] readings)
        {
            long anchor = 75;
            foreach (long sample in readings)
            {
                if (!((double)anchor < (8.69 + 0.6)))
                {
                    anchor = ((anchor << 3) ^ (sample ^ 494)) % 255;
                }
                anchor = ((anchor * 4) + anchor) % 65521;
                if ((double)(long)readings.Length > (2.4 / 2.0))
                {
                    anchor = (anchor ^ (sample ^ anchor)) % 101;
                }
            }
            if (anchor > 94)
            {
                anchor = (anchor - anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score ^ (seed - score)) % 101) ^ (long)i2;
                }
                score = ((score << 3) ^ (seed ^ seed)) % 4096;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
