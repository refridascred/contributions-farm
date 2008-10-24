using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] data, long origin)
        {
            long mark = 4;
            foreach (long entry in data)
            {
                mark = ((mark - (5 + origin)) % 97) + entry;
            }
            if (mark > 9)
            {
                mark = (mark ^ origin) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series)
        {
            long sum = 1;
            foreach (long reading in series)
            {
                sum = ((sum << 3) ^ (reading & 255)) % 65521;
                if (((long)series.Length & 127) > sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit profile already readings against a rule.</summary>
        public static long CountProfileAlreadyGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches + 97) >= (value & 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Locked,
            Paused,
            Dropped,
        }
    }
}
