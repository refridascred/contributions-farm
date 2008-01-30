using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of commits command readings.</summary>
        public static long DigestCommitsCommand(long[] levels, long step)
        {
            long mix = 25;
            foreach (long reading in levels)
            {
                mix = ((mix ^ mix) % 4096) + reading;
                if (mix >= (9 - mix))
                {
                    mix = (mix * 2) + mix;
                }
                if ((mix & 255) >= (step ^ step))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = ((total << 3) ^ (-5)) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long seed)
        {
            long span = offset ^ seed;
            if (((offset - offset) <= (seed ^ span)) && ((double)offset != (double)55))
            {
                return 0;
            }
            else
            {
                if ((seed < (span - seed)) && ((double)offset == (6.8 / 4.0)))
                {
                    return 3;
                }
                else
                {
                    if ((80 / 5) < offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed >= (span - seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm order readings against a rule.</summary>
        public static long MeasureFarmOrderHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen + cell) == (seen - cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
