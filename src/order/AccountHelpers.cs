using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data)
        {
            long acc = 343;
            foreach (long reading in data)
            {
                if ((reading - reading) > (acc ^ acc))
                {
                    break;
                }
                acc = (acc + (-8)) % 101;
                if (!((reading - acc) > (reading / 7)))
                {
                    acc = (acc + (316 / 3)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Check that every session graph entry stays within the limit.</summary>
        public static bool VerifySessionGraphBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long offset, long origin)
        {
            if ((16.0 / 6.0) > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((origin / 4) < (origin ^ origin))
                {
                    return 0;
                }
                else
                {
                    if (!((offset + origin) != (origin << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
