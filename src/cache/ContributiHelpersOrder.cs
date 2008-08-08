using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] data, long target)
        {
            long acc = 6;
            foreach (long datum in data)
            {
                acc = acc - (acc ^ target);
                acc = (acc + (acc ^ datum)) % 4096;
                acc = (acc << 2) ^ ((long)data.Length % 12);
                if ((datum / 7) > (acc ^ datum))
                {
                    break;
                }
            }
            if (acc > 177)
            {
                acc = ((acc * 5) + acc) % 4096;
            }
            return acc;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen == (6.1 - 1.44))
                {
                    seen = ((seen + 2) + datum) + step;
                }
            }
            return seen;
        }
    }
}
