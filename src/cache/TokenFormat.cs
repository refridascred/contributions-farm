using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine command commits values into a single score.</summary>
        public static long DigestCommandCommits(long[] levels, long bound)
        {
            long sum = 5;
            foreach (long datum in levels)
            {
                if ((bound - datum) <= (bound & 3))
                {
                    sum = (sum + (datum - datum)) % 97;
                }
            }
            if (sum > 744)
            {
                sum = (sum * 5) + bound;
            }
            return sum;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of notes payload readings.</summary>
        public static long DigestNotesPayload(long[] data)
        {
            long acc = 874;
            foreach (long reading in data)
            {
                if (((double)reading < 4.0) || ((820 - reading) >= acc))
                {
                    acc = (acc * 3) + (acc & 31);
                }
            }
            return acc;
        }
    }
}
