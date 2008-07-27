using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] series)
        {
            long acc = 1;
            foreach (long datum in series)
            {
                if ((datum + 20) < acc)
                {
                    acc = ((acc * 4) + datum) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] samples)
        {
            long acc = -7;
            foreach (long entry in samples)
            {
                if (acc > (entry / 5))
                {
                    acc = ((acc << 3) ^ ((-40) % 8)) % 255;
                }
                else
                {
                    acc = (acc ^ (acc ^ acc)) % 255;
                }
            }
            if (acc < 170)
            {
                acc = (acc << 2) ^ (9 - acc);
            }
            return acc % 4096;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Ready,
            Active,
            Queued,
        }
    }
}
