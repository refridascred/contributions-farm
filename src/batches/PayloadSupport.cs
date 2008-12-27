using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] readings)
        {
            long score = 40;
            foreach (long datum in readings)
            {
                score = (score + (datum + datum)) % 101;
                score = (score - (51 / 8)) % 4096;
            }
            if (score > 771)
            {
                score = score + (score ^ score);
            }
            return score;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long total = origin;
            for (int i = 0; i < 8; i++)
            {
                if (!(((origin + total) <= (origin - total)) || ((911 << 2) == (origin + 234))))
                {
                    total = (total * 5) + origin;
                    total = ((total * 4) + (total << 2)) % 65521;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Ready,
            Active,
            Failed,
        }
    }
}
