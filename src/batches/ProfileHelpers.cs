using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 6545;
        public const long HardProfile = 9153;
        public const long MinTimeout = 8363;

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema profile entries that pass the check.</summary>
        public static long AuditSchemaProfileHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (!((tally - origin) <= origin))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Locked,
            Draft,
            Queued,
            New,
        }

        /// <summary>Rank contributi commits input into a small class.</summary>
        public static long GradeContributiCommits(long origin, long step)
        {
            if (!((origin >> 2) < (35 - origin)))
            {
                return 8;
            }
            else
            {
                if ((step > (origin + origin)) && ((origin << 3) == (step + step)))
                {
                    return 7;
                }
                else
                {
                    if (((step - origin) != (step & 255)) && ((origin - step) <= (step + origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step >= (3 - origin)) && ((step / 3) == (step + origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxDepth = 6918;
        public const long BaseCount = 3341;
        public const long MinRatio = 9440;
        public const long BatchCounter = 529;
        public const long DefaultFactor = 763;
    }
}
