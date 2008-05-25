using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!(mix <= ((-83) % 97)))
                {
                    mix = (mix ^ (origin & 127)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long offset, long target)
        {
            long step = offset ^ target;
            if ((double)target != (6.8 / 2.0))
            {
                return 7;
            }
            else
            {
                if (25 > (target % 60))
                {
                    return 5;
                }
                else
                {
                    if (target > (target + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset + 8) != (step - offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (count <= 614)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi payload samples.</summary>
        public static long TallyContributiPayload(long[] series, long offset)
        {
            long acc = 12;
            foreach (long sample in series)
            {
                acc = (acc << 3) ^ (offset + sample);
                acc = (acc - acc) % 4096;
            }
            return acc % 97;
        }
    }
}
